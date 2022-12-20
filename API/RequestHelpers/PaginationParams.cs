using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.RequestHelpers
{
    public class PaginationParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pagesSize = 6;
        public int PageSize
        {
            get => _pagesSize;
            set => _pagesSize = value > MaxPageSize ? MaxPageSize : value;
        }
    }
}