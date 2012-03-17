﻿// -----------------------------------------------------------------------
// <copyright file="AccessTokenRefreshRequestAS.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2.AuthServer.Messages {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using DotNetOpenAuth.OAuth2.AuthServer.ChannelElements;
	using DotNetOpenAuth.OAuth2.ChannelElements;
	using DotNetOpenAuth.OAuth2.Messages;

	/// <summary>
	/// TODO: Update summary.
	/// </summary>
	internal class AccessTokenRefreshRequestAS : AccessTokenRefreshRequest, IRefreshTokenCarryingRequest {
			/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokenRefreshRequestAS"/> class.
		/// </summary>
		/// <param name="tokenEndpoint">The token endpoint.</param>
		/// <param name="version">The version.</param>
		internal AccessTokenRefreshRequestAS(Uri tokenEndpoint, Version version)
			: base(tokenEndpoint, version) {
		}

	#region IRefreshTokenCarryingRequest members

		/// <summary>
		/// Gets or sets the verification code or refresh/access token.
		/// </summary>
		/// <value>The code or token.</value>
		string IRefreshTokenCarryingRequest.RefreshToken {
			get { return this.RefreshToken; }
			set { this.RefreshToken = value; }
		}

		/// <summary>
		/// Gets or sets the authorization that the token describes.
		/// </summary>
		RefreshToken IRefreshTokenCarryingRequest.AuthorizationDescription { get; set; }

		/// <summary>
		/// Gets the authorization that the token describes.
		/// </summary>
		IAuthorizationDescription IAuthorizationCarryingRequest.AuthorizationDescription {
			get { return ((IRefreshTokenCarryingRequest)this).AuthorizationDescription; }
		}

		#endregion
	}
}
