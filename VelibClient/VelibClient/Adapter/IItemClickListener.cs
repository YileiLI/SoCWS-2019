using Android.Views;
using System;

public interface IItemClickListener
{
    void OnClick(View itemView, int position, bool isLongClick);
}
