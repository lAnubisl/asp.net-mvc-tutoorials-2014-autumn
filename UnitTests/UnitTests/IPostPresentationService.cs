using System.Collections.Generic;
using UnitTests.Models;

namespace UnitTests
{
    public interface IPostPresentationService
    {
        ICollection<PostItemViewModel> GetItems(int count);
    }
}