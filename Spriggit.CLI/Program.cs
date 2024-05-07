﻿using System.Globalization;
using CommandLine;
using Spriggit.CLI;
using Spriggit.CLI.Commands;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

return await Parser.Default.ParseArguments(args, typeof(DeserializeCommand), typeof(SerializeCommand), typeof(FormIDCollisionCommand))
    .MapResult(
        async (DeserializeCommand deserialize) => await EngineRunner.Run(deserialize),
        async (SerializeCommand serialize) => await EngineRunner.Run(serialize),
        async (FormIDCollisionCommand formIdCollision) => await FormIDCollisionRunner.Run(formIdCollision),
        async _ => -1);