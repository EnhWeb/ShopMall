
	//----------Shop_advertisement_img开始----------
    

using System;
using ShopMall.FrameWork.IServices;
using ShopMall.FrameWork.IRepository;
using ShopMall.FrameWork.Entity;

namespace ShopMall.FrameWork.Services
{	
	/// <summary>
	/// Shop_advertisement_imgServices
	/// </summary>	
	public class Shop_advertisement_imgServices : BaseServices<Shop_advertisement_img>, IShop_advertisement_imgServices
    {
	
        IShop_advertisement_imgRepository dal;
        public Shop_advertisement_imgServices(IShop_advertisement_imgRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
       
    }
}

	//----------Shop_advertisement_img结束----------
	