﻿namespace Lib_K_Relay.Networking.Packets.Client
{
	public class AcceptArenaDeathPacket : Packet
	{
		public override PacketType Type
		{ get { return PacketType.ACCEPTARENADEATH; } }

		public override void Read(PacketReader r)
		{
		}

		public override void Write(PacketWriter w)
		{
		}
	}
}
