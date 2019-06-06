
	//----------Shop_shopCar开始----------
    

using System;
using ShopMall.IServices;
using ShopMall.IRepository;
using ShopMall.Model.Models;
using ShopMall.Services.BASE;
namespace ShopMall.Services
{	
	/// <summary>
	/// Shop_shopCarServices
	/// </summary>	
	public class Shop_shopCarServices : BaseServices<Shop_shopCar>, IShop_shopCarServices
    {
	
        IShop_shopCarRepository dal;
        public Shop_shopCarServices(IShop_shopCarRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
       
    }
}

	//----------Shop_shopCar结束----------
	