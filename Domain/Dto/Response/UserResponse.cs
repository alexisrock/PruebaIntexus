using Domain.Common;
using Domain.Commonds;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Response
{
    [ExcludeFromCodeCoverage]
    public class UserResponse: BaseResponse
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
    
    }
}
