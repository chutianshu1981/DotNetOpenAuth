// <auto-generated />

//
// DHParameters.cs: Defines a structure that holds the parameters of the Diffie-Hellman algorithm
//
// Author:
//	Pieter Philippaerts (Pieter@mentalis.org)
//
// (C) 2003 The Mentalis.org Team (http://www.mentalis.org/)
//
// Source Code License
// Copyright � 2002-2007, The Mentalis.org Team
// All rights reserved.
// http://www.mentalis.org/
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// - Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer. 
// - Neither the name of the Mentalis.org Team, nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

namespace Org.Mentalis.Security.Cryptography {
	/// <summary>
	/// Represents the parameters of the Diffie-Hellman algorithm.
	/// </summary>
	internal struct DHParameters {
		/// <summary>
		/// Represents the public <b>P</b> parameter of the Diffie-Hellman algorithm.
		/// </summary>
		public byte[] P;
		/// <summary>
		/// Represents the public <b>G</b> parameter of the Diffie-Hellman algorithm.
		/// </summary>
		public byte[] G;
		/// <summary>
		/// Represents the private <b>X</b> parameter of the Diffie-Hellman algorithm.
		/// </summary>
		public byte[] X;
	}
}