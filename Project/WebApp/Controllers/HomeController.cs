using InstrumentShop.BusinessLayer;
using InstrumentShop.DataAccessLayer;
using InstrumentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfInstrument _unitOfInstrument;
        private readonly ICategoryService _categoryService;
        private readonly IOrderService _orderService;
        public HomeController()
        {
            _unitOfInstrument = new UnitOfInstrument();
            _categoryService = new CategoryService(_unitOfInstrument);
            _orderService = new OrderService(_unitOfInstrument);
        }

        public ActionResult Category(int id)
        {
            var model = new CategoryViewModel
            {
                Title = "Instrument Shop",
                Category = _categoryService.Get(id)
            };
            return View(model);
        }

        public ActionResult Index(string search, string sort)
        {
            var sortBy = new Sort()
            {
                Field = "Name",
                Direction = SortOrder.Ascending
            };
            if(sort == "desc")
            {
                sortBy.Direction = SortOrder.Descending;
            }

            search = Sanitize(search);
            sort = Sanitize(sort);

            var model = new CategoryListViewModel
            {
                Title = "Instrument Shop",
                Search = search,
                Sort = sort,
                Categories = _categoryService.List(search, sortBy)
            };
            return View(model);
        }

        private string Sanitize(string text)
        {
            if (text != null)
            {
                text = Regex.Replace(text, @"(\<[^\<]*\>)", "");
            }
            return text;
        }

        public Action OrderButton(int id)
        {
            Instrument instrument = _unitOfInstrument.InstrumentRepository.Get(id);
            if (instrument.QuantityLeft > 0)
            {
                OrderModel order = new OrderModel();
                order.ID = Guid.NewGuid().GetHashCode();
                order.ItemID = id;
                order.Quantity = 1;
                order.PriceTotal = instrument.PricePerItem;
                _orderService.Add(order);
                instrument.QuantityLeft -= order.Quantity;
                _unitOfInstrument.InstrumentRepository.Update(instrument);

                return null;
            }
            else
            {
                return null;
            }
            
        }
    }
}