using BookManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var memberRepository = new MembersRepository();
            var bookRepository = new BookRepository();

            var result = memberRepository.GetMemberById(2);
            if (result.Success)
            {
                Console.WriteLine(result.Data.MemberName);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            var res = bookRepository.GetBookById(2);
            if (res.Success)
            {
                Console.WriteLine(res.Data.Title);
            }
            else
            {
                Console.WriteLine(res.Message);
            }
            var searchEmail = memberRepository.GetMemberByEmail("member1@gmail.com");
            if (searchEmail.Success)
            {
                Console.WriteLine(searchEmail.Data.MemberName);
            }
            else
            {
                Console.WriteLine(searchEmail.Message);
            }
        }
    }
}
