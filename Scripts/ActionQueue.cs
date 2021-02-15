using System;
using System.Collections;
using System.Collections.Generic;

public class ActionQueue
{
    List<IActionItem> items = new List<IActionItem>();

    public void Add(IActionItem item)
    {
        items.Add(item);
    }

    public IEnumerator run()
    {
        foreach (IActionItem item in items)
        {
            yield return item.use();
        }
    }
}

