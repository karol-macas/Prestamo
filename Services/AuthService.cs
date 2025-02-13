using PlataformaPrestamo.Security;
using PlataformaPrestamos.Models;
using PlataformaPrestamos.Repositories;
using PlataformaPrestamos.Security;

namespace PlataformaPrestamos.Services
{
    public class AuthService
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly TokenService _tokenService;

        public AuthService(UsuarioRepository usuarioRepository, TokenService tokenService)
        {
            _usuarioRepository = usuarioRepository;
            _tokenService = tokenService;
        }

        public string Login(string email, string contraseña)
        {
            var usuario = _usuarioRepository.GetByEmail(email);

            if (usuario == null || !BCrypt.Net.BCrypt.Verify(contraseña, usuario.ContraseñaHash))
                return null;

            return _tokenService.GenerateToken(usuario);
        }

        public void Register(Usuario usuario)
        {
            usuario.ContraseñaHash = BCrypt.Net.BCrypt.HashPassword(usuario.ContraseñaHash);
            _usuarioRepository.Add(usuario);
        }
    }
}