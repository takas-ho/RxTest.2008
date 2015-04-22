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
        }
    }
}
