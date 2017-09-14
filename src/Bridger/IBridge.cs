using System;
using System.Collections.Generic;
using System.Text;

namespace Bridger
{
    public interface IBridge
    {
    }


    public interface IBridge<TIn, TOut> : IBridge
    {
        void Bridge(TIn input, TOut output);
    }

    public static class IBridge_Extensions
    {
        public static void Bridge<TIn, TOut>(this IBridge<TIn, TOut> bridge, ITransportIn<TIn> transportIn, ITransportOut<TOut> transportOut)
            where TIn: new()
            where TOut: new()
        {
            var input = new TIn();
            var output = new TOut();

            transportIn.Read(input);
            bridge.Bridge(input, output);
            transportOut.Write(output);
        }
    }
}
