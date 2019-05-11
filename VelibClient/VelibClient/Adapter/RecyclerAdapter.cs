using System;
using System.Collections.Generic;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace VelibClient.Adapter {

    public class RecyclerViewHolder : RecyclerView.ViewHolder, View.IOnClickListener
    {
        public TextView station;
        IItemClickListener itemClickListener;
        public RecyclerViewHolder(View itemView):base(itemView)
        {
            station = itemView.FindViewById<TextView>(Resource.Id.station);
            itemView.SetOnClickListener(this);
        }

        public void SetItemClickListener(IItemClickListener itemClickListener)
        {
            this.itemClickListener = itemClickListener;
        }
        public void OnClick(View v)
        {
            itemClickListener.OnClick(v, AdapterPosition, false);
        }

        public bool OnLongClick(View v)
        {
            itemClickListener.OnClick(v, AdapterPosition, true);
            return true;
        }
    }

    public class RecyclerAdapter : RecyclerView.Adapter, IItemClickListener
    {
        private List<string> datas = new List<string>();
        private Context context;

        public RecyclerAdapter(List<string> datas, Context context)
        {
            this.datas = datas;
            this.context = context;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecyclerViewHolder vh = holder as RecyclerViewHolder;
            vh.station.Text = datas[position];
            vh.SetItemClickListener(this);

        }
        public override int ItemCount => datas.Count;

        public void OnClick(View itemView, int position, bool isLongClick)
        {
            if (isLongClick)
            {
                Toast.MakeText(context, "Long Click" + datas[position], ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(context, "Click" + datas[position], ToastLength.Short).Show();

            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View itemView = inflater.Inflate(Resource.Layout.city_item,
                parent, false);
            return new RecyclerViewHolder(itemView);
        }
    }
}
