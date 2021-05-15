using AutoMapper;
using DotnetCoreLearning.Mdl.Model;
using DotnetCoreLearning.Bll.Interface;
using DotnetCoreLearning.Dal.Models;

namespace DotnetCoreLearning.Bll.Service
{
    public class UserService: IUserService
    {
        private QueryTestContext _db;
        private IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public object GetUserName() {
            using(_db = new QueryTestContext()) {
                long id = 1;
                var entity = _db.Cources.Find(id);
                var model = _mapper.Map<CourceStruct>(entity);
                return model;
            }
        }
    }
}