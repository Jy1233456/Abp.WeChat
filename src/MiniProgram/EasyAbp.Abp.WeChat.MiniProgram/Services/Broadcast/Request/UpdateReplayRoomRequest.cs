﻿using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
    public class UpdateReplayRoomRequest : MiniProgramCommonRequest
    {
        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        [JsonProperty("closeReplay")]
        public int CloseReplay { get; set; }
    }
}
