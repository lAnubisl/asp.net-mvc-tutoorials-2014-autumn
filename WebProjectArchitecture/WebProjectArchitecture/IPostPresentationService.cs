using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectArchitecture.Models;

namespace WebProjectArchitecture
{
    public interface IPostPresentationService
    {
        ICollection<PostItemViewModel> GetItems(int count); 
    }
}
