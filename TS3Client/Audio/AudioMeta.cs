// TS3Client - A free TeamSpeak3 client implementation
// Copyright (C) 2017  TS3Client contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.

using System.Collections.Generic;

namespace TS3Client.Audio
{
	public class Meta
	{
		public Codec? Codec { get; set; }
		public MetaIn In;
		public MetaOut Out { get; set; }
		//public PipeControl Control { get; set; }
	}

	public struct MetaIn
	{
		public ClientId Sender { get; set; }
		public bool Whisper { get; set; }
	}

	public class MetaOut
	{
		public TargetSendMode SendMode { get; set; }
		public ulong TargetId { get; set; }
		public GroupWhisperTarget GroupWhisperTarget { get; set; }
		public GroupWhisperType GroupWhisperType { get; set; }
		public IReadOnlyList<ChannelId> ChannelIds { get; set; }
		public IReadOnlyList<ClientId> ClientIds { get; set; }
	}

	public enum TargetSendMode
	{
		None,
		Voice,
		Whisper,
		WhisperGroup,
	}

	public enum PipeControl
	{
		Data,
		EmptyTick,
	}
}
