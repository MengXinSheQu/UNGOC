using Exiled.API.Features;
using SCPSLAudioApi.AudioCore;
using System;
using VoiceChat;
using UnityEngine;
using Mirror;
using Object = UnityEngine.Object;

namespace UNGOC.SteveAPI
{
    internal class Dummy
    {
        private static ReferenceHub Bot;
        public static void Destory()
        {
            if (Bot == null)
                return;
            AudioPlayerBase audioPlayerBase = AudioPlayerBase.Get(Bot);
            if (audioPlayerBase.CurrentPlay != null)
            {

                audioPlayerBase.Stoptrack(true);
                audioPlayerBase.OnDestroy();
            }
            try
            {
                NetworkServer.RemovePlayerForConnection(Player.Get(Bot).Connection, true);
            }
            catch
            {

            }
        }
        public static AudioPlayerBase PlaySound(string Path)
        {
            if (Bot == null)
            {
                Add("C.A.S.S.I.E.");
            }
            ReferenceHub component = Bot;
            AudioPlayerBase audioPlayerBase = AudioPlayerBase.Get(component);
            audioPlayerBase.Enqueue(Path, -1);
            audioPlayerBase.LogDebug = false;
            audioPlayerBase.BroadcastChannel = VoiceChatChannel.Intercom;
            audioPlayerBase.Volume = 50f;
            audioPlayerBase.Loop = false;
            audioPlayerBase.Play(0);
            return audioPlayerBase;
        }
        public static void Add(string Name)
        {
            if (Bot != null)
                return;
            GameObject player1 = Object.Instantiate(NetworkManager.singleton.playerPrefab);
            int networkConnectionId = 13422;
            NetworkServer.AddPlayerForConnection(new FakeConnection(networkConnectionId), player1);
            ReferenceHub component = player1.GetComponent<ReferenceHub>();
            Player player = Player.Get(component);
            player.DisplayNickname = Name;
            Bot = component;
        }
        private class FakeConnection : NetworkConnectionToClient
        {
            public FakeConnection(int networkConnectionId) : base(networkConnectionId)
            {

            }
            public override string address => "localhost";
            public override void Send(ArraySegment<byte> segment, int channelId = 0)
            {

            }
            public override void Disconnect()
            {

            }
        }
    }
}
