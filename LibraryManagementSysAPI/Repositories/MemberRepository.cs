using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSysAPI.Data;
using LibraryManagementSysAPI.Models;
namespace LibraryManagementSysAPI.Repositories
{
    public class MemberRepository : BaseRepository<Member>
    {
       /* List<Member> _members = new List<Member>() { new Member { Id=1,MName="Faraz",MContact="0333-0000001",MType="Staff",MNoOfBookIssued=2} ,
        new Member { Id=2,MName="Hira",MContact="0333-0000002",MType="Staff",MNoOfBookIssued=3},
        new Member { Id=3,MName="Tulaib",MContact="0333-0000003",MType="Student",MNoOfBookIssued=2},
        new Member { Id=4,MName="Mehmaam",MContact="0333-0000004",MType="Student",MNoOfBookIssued=3}
        };*/

        public MemberRepository(ApplicationDbContext db) : base(db)
        {
        }
    }

}
