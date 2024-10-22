using BookManagement.Data;
using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Repositories
{
    internal class MembersRepository
    {
        public GenericResponses<List<Members>> GetAllMembers()
        {
            var members = DataStore.Members;
            return new GenericResponses<List<Members>>
            {
                Success = true,
                Data = members,
            };
        }
        public GenericResponses<Members> GetMemberById(int id)
        {
            var members = DataStore.Members.FirstOrDefault(x => x.MemberId == id);
            if (members == null)
            {
                return new GenericResponses<Members>
                {
                    Success = false,
                    Message = "Member not Found",
                };
            }
            return new GenericResponses<Members>
            {
                Success = true,
                Data = members,
            };
        }
        public GenericResponses<Members> GetMemberByEmail(string email)
        {
            var members = DataStore.Members.FirstOrDefault(x => x.Email == email);
            if (members == null)
            {
                return new GenericResponses<Members>
                {
                    Success = false,
                    Message = "Member not Found",
                };
            }
            return new GenericResponses<Members>
            {
                Success = true,
                Data = members,
            };
        }
    }
}
