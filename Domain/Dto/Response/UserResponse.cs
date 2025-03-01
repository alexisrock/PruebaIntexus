using Domain.Common;
using Domain.Commonds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Response
{
    public class UserResponse: BaseResponse
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
    
    }
}
