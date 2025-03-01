using System.Collections.Generic;
using Domain.Common;
using Domain.Dto.Response;
using Domain.Entities;
using MediatR;

namespace Domain.Dto.Request
{
    public class TareaRequest : IRequest<BaseResponse>
    {
        public string NameTarea { get; set; } = string.Empty;
        public string DescriptionTarea { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

    }


    public class TareaupdateRequest : IRequest<BaseResponse>
    {
        public int IdTarea { get; set; }       
        public bool IsCompleted { get; set; }

    }

    public class TareaDeleteRequest : IRequest<BaseResponse>
    {
        public int IdTarea { get; set; }       

    }


    public class TareaGetRequest : IRequest<List<TareaResponse>>
    {   
    }


}
