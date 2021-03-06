﻿using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200008A RID: 138
internal class PicPacket : Packet
{
	// Token: 0x17000123 RID: 291
	// (get) Token: 0x060003FE RID: 1022 RVA: 0x00015F0C File Offset: 0x0001410C
	public override PacketType Type
	{
		get
		{
			return PacketType.PIC;
		}
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00015F1C File Offset: 0x0001411C
	public override void Read(PacketReader r)
	{
		this.BitmapData = (BitmapData)this.BitmapData.Read(r);
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00015F40 File Offset: 0x00014140
	public override void Write(PacketWriter w)
	{
		this.BitmapData.Write(w);
	}

	// Token: 0x04000537 RID: 1335
	public BitmapData BitmapData;
}
