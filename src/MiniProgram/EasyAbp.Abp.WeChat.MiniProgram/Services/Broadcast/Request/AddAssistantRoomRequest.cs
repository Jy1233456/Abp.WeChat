﻿using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.Broadcast.Request
{
    public class AddAssistantRoomRequest : MiniProgramCommonRequest
    {

        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        [JsonProperty("users")]
        public List<Users> Users { get; set; }
    }
    public class Users
    {
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }
    }
}
