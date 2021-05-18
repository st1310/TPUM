using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.CommonLogic
{
    public class CommonLogicFactory
    {
        private static Mapper _mapper = null;
        public static Mapper Mapper
        {
            get
            {
                _mapper ??= new Mapper();
                return _mapper ?? new Mapper();
            }

            set
            {
                _mapper = value;
            }
        }
    }
}
