using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using NUnit.Framework;

namespace RxC
{
    class Rx0201Test
    {
        [Test] public void ObservableによるRx的コード()
        {
            var result =new List<int>();
            Observable.Range(1, 5).Subscribe(x => result.Add(x));
            Assert.That(result.Count, Is.EqualTo(5));
            Assert.That(string.Join(",", result.ConvertAll(x => x.ToString()).ToArray()), 
                Is.EqualTo("1,2,3,4,5"));
        }

        [Test] public void Enumberableによるコード()
        {
            var result = new List<int>();
            foreach (var x in Enumerable.Range(1, 5))
            {
                result.Add(x);                
            }
            Assert.That(result.Count, Is.EqualTo(5));
            Assert.That(string.Join(",", result.ConvertAll(x => x.ToString()).ToArray()), 
                Is.EqualTo("1,2,3,4,5"));
        }

    }
}
