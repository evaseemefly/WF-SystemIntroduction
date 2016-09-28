using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WFLibrary
{

    public sealed class resultBookmark<T> :  NativeActivity<T>
    {
         public InArgument<string> bookmarkName { get; set; }

        protected override bool CanInduceIdle
        {
            get
            {     return true;        }
        }
        protected override void Execute(NativeActivityContext context)
        {
            string bookmark = context.GetValue(bookmarkName);
            context.CreateBookmark(bookmark,new BookmarkCallback(bookmarkCallback));
             System.Console.WriteLine("创建bookmark:{0}", bookmark);
        }
        void bookmarkCallback(NativeActivityContext context, Bookmark bookmark, object obj)
        {
            this.Result.Set(context, (T)obj);
        }
    }
}
