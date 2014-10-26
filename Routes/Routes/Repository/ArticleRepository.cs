using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest.Repository
{
    public static class ArticleRepository
    {
        private static readonly Dictionary<String, Article> Articles = new Dictionary<string, Article>();

        static ArticleRepository()
        {
        }
    }
}