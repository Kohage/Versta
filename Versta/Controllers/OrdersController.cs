﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using Versta.Data.Interfaces;
using Versta.Data.Models;
using System.Windows;

namespace Versta.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public ViewResult Index()
        {
            try
            {
                var orsersModel = _orderService.GetAllOrder();
            return View(orsersModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel orderModel)
        {
            try
            {
                _orderService.SaveOrderAsync(orderModel);

                TempData["msg"] = "<script>alert('Запись успешно сохранена');</script>";
                return RedirectToAction(nameof(Create));
            }
            catch (Exception ex)
            {
                TempData["msg"] = "<script>alert('Ошибка');</script>";
                throw new Exception(ex.Message);
            }
        }
        public ViewResult Read(int id)
        {
            try
            {
                var orserModel = _orderService.GetOrder(id);
            return View(orserModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string OpenModelPopup()
        {
            //can send some data also.  
            return "<h1>This is Modal Popup Window</h1>";
        }
    }
}
