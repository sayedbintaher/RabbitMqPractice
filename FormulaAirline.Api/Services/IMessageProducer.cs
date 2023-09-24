using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulaAirline.Api.Services
{
    public interface IMessageProducer
    {
        public void SendMessages<T>(T message);
    }
}