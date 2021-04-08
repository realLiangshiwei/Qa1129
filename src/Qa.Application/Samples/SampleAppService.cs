using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace Qa.Samples
{
    public class SampleAppService : QaAppService, ISampleAppService
    {
        private IRepository<IdentityUser> _userRepository;

        public SampleAppService(IRepository<IdentityUser> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<SampleDto> GetAsync()
        {
            var users = await _userRepository.FirstOrDefaultAsync();
            return new SampleDto
            {
                UserName = users.UserName
            };
        }

        [Authorize]
        public Task<SampleDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                }
            );
        }
    }
}
