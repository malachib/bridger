using System;

namespace Bridger
{
    public interface ITransport
    {

    }


    public interface ITransportIn<TIn> : ITransport
    {
        void Read(TIn input);
    }

    public interface ITransportOut<TOut> : ITransport
    {
        void Write(TOut output);
    }
}
