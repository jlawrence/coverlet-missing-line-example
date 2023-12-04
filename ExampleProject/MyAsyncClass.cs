using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    public class MyAsyncClass
    {
        public async Task<int> DoAsyncAction()
        {
            return await Task.FromResult<int>(1);
        }
    }
}
