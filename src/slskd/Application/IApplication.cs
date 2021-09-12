﻿// <copyright file="IApplication.cs" company="slskd Team">
//     Copyright (c) slskd Team. All rights reserved.
//
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as published
//     by the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
//
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see https://www.gnu.org/licenses/.
// </copyright>

namespace slskd
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Hosting;
    using Soulseek;

    public interface IApplication : IHostedService
    {
        public Task CheckVersionAsync();
        public Task ConnectAsync();
        public void Disconnect(string message = null, Exception exception = null);
        public Task RescanSharesAsync();
        public Task StartPublicChatAsync();
        public Task StopPublicChatAsync();
        public Task AcknowledgePrivateMessageAsync(int id);
        public Task SendPrivateMessageAsync(string username, string message);
        public Task SendRoomMessageAsync(string roomName, string message);
        public Task SetRoomTickerAsync(string roomName, string message);
        public Task AddPrivateRoomMemberAsync(string roomName, string username);
        public Task<RoomList> GetRoomListAsync();
        public Task<RoomData> JoinRoomAsync(string roomName);
        public Task LeaveRoomAsync(string roomName);
        public Task DownloadAsync(string username, string filename, Stream outputStream, long? size, long startOffset = 0, int? token = null, TransferOptions options = null, CancellationToken? cancellationToken = null);
        public Task<int> GetDownloadPlaceInQueueAsync(string username, string filename);
    }
}
