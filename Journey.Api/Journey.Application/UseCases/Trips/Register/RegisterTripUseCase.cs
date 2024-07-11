using Journey.Communication.Requests;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey.Application.UseCases.Trips.Register
{
    public class RegisterTripUseCase
    {
        public void Execute(RequestRegisterTripJson request)
        {
             Validate(request);
        } 
        
        private void Validate(RequestRegisterTripJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                throw new JourneyException( ResourceErrorMessage.NAME_EMPTY );
            }

            if (request.StartDate.Date < DateTime.UtcNow)
            {
                throw new ArgumentException(ResourceErrorMessage.DATE_TRIP_MUST_BE_LATER_THAN_TODAY);
            }

            if (request.EndDate.Date >= request.StartDate.Date)
            {
                throw new ArgumentException(ResourceErrorMessage.END_DATE_TRIP_MUST_BE_LATER_START_DATE);
            }
        }
    }
}
