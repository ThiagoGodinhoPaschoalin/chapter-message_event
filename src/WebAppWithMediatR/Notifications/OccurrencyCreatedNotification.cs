﻿using MediatR;
using SharedDomain.Models;

namespace WebAppWithMediatR.Notifications
{
    public class OccurrencyCreatedNotification : INotification
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model">Não injetar o modelo diretamente! Aqui foi somente para focar na comunicação. Crie um DTO, e use AutoMapper para conversão de classe.</param>
        public OccurrencyCreatedNotification(OccurrencyModel model)
        {
            Model = model;
        }

        public OccurrencyModel Model { get; }
    }
}