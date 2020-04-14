using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Core.Helpers
{
    public interface IAndroidId
    {
        //event EventHandler<AndroidIdEventArgs> OnAndroidId;

        Task<string> GetAndroidId();
    }


        public class AndroidIdEventArgs :EventArgs
        {
            public string AndroidId { get; set; }
        }
}
