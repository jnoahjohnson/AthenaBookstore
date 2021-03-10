using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using AthenaBookstore.Infrastructure;

namespace AthenaBookstore.Models
{

    // Thisis a sublcass of the cart class and it overrides the method so that they do the original implementationsa dn then store the state in the session
    public class SessionCart : Cart
    {
        // Factory for creating SessionCart Objects
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();

            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Book book, int quantity)
        {
            base.AddItem(book, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Book book)
        {
            base.RemoveLine(book);
            Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
