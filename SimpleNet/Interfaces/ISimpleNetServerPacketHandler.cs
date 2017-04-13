﻿using System;
using SimpleNet.Common;
using SimpleNet.Interfaces;

namespace SimpleNet.Server
{
    public interface ISimpleNetServerPacketHandler
    {
        Type GetPacketType();
        void Handle(ISimpleNetConnection clientConnection, SimpleNetPacketBase packet, byte[] bytes);
    }
}