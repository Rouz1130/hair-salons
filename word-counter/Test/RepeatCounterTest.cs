using System.Collections.Generic;
using Xunit;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounterTest : IDisposable
  {
    public void Dispose()
    {
      RepeatCounter.DeleteAll();
    }

      [Fact]
      public void Test1_RepeatCounterGetA_true()
      {

        RepeatCounter newRepeatCounter = new RepeatCounter("a");
        string testCounter = newRepeatCounter.GetWord();
        Assert.Equal("a", testCounter);
    }

  }

}
