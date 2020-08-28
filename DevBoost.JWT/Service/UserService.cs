using DevBoost.JWT.Contract;
using DevBoost.JWT.Helper;
using DevBoost.JWT.Model;
using Flunt.Notifications;
using System;
using System.Threading.Tasks;

namespace DevBoost.JWT.Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public UserService(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<Response> Authentication(User user)
        {

            Response _response= new Response();
            // Recupera o usuário
            var user_temp = _userRepository.Get(user.Username, user.Password);

            // Verifica se o usuário existe
            if (user_temp == null)
            {
                _response.AddNotification(new Notification("user", "Usuário ou senha inválidos"));
                return _response;
            }

            var jwt = _tokenService.CreateJWT(user);

            _response.AddValue(new
            {
                user.Username,
                jwt
            });
            return _response;

        }
    }
}
