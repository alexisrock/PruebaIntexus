using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dto.Request;
using Domain.Dto.Response;
using Domain.Entities;

namespace Application.TransformDto
{
    [ExcludeFromCodeCoverage]
    internal static class Transform
    {
 

        internal static Tarea MapperTareaUpdate(this Tarea tarea, TareaupdateRequest request)
        {
            tarea.IsCompleted = request.IsCompleted;
            return tarea;
        }


        internal static List<TareaResponse> MapperListTarea(this IEnumerable<Tarea> listTarea)
        {
            List<TareaResponse> tareaResponses = new List<TareaResponse>();

            listTarea.ToList().ForEach(response => {             
            var tareaResponse = new TareaResponse();
                tareaResponse.IsCompleted = response.IsCompleted;
                tareaResponse.NameTarea = response.NameTarea;
                tareaResponse.DescriptionTarea = response.DescriptionTarea;
                tareaResponse.IdTarea = response.IdTarea;
                tareaResponses.Add(tareaResponse);
            });


            return tareaResponses;

        }
    }
}
