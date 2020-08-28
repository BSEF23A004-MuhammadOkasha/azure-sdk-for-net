﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Security.KeyVault.Keys.Cryptography
{
    internal abstract class LocalCryptographyProvider : ICryptographyProvider
    {
        private readonly KeyProperties _keyProperties;

        public LocalCryptographyProvider(JsonWebKey keyMaterial, KeyProperties keyProperties)
        {
            KeyMaterial = keyMaterial ?? throw new ArgumentNullException(nameof(keyMaterial));
            _keyProperties = keyProperties;
        }

        public bool ShouldRemote => KeyMaterial?.Id != null;

        protected JsonWebKey KeyMaterial { get; set; }

        protected bool MustRemote => ShouldRemote && !KeyMaterial.HasPrivateKey;

        public abstract bool SupportsOperation(KeyOperation operation);

        public virtual DecryptResult Decrypt(EncryptionAlgorithm algorithm, byte[] ciphertext, CancellationToken cancellationToken = default)
        {
            throw ThrowOperationNotSupported(nameof(Decrypt));
        }

        public virtual Task<DecryptResult> DecryptAsync(EncryptionAlgorithm algorithm, byte[] ciphertext, CancellationToken cancellationToken = default)
        {
            DecryptResult result = Decrypt(algorithm, ciphertext, cancellationToken);
            return Task.FromResult(result);
        }

        public virtual EncryptResult Encrypt(EncryptionAlgorithm algorithm, byte[] plaintext, CancellationToken cancellationToken = default)
        {
            throw ThrowOperationNotSupported(nameof(Encrypt));
        }

        public virtual Task<EncryptResult> EncryptAsync(EncryptionAlgorithm algorithm, byte[] plaintext, CancellationToken cancellationToken = default)
        {
            EncryptResult result = Encrypt(algorithm, plaintext, cancellationToken);
            return Task.FromResult(result);
        }

        public virtual SignResult Sign(SignatureAlgorithm algorithm, byte[] digest, CancellationToken cancellationToken = default)
        {
            throw ThrowOperationNotSupported(nameof(Sign));
        }

        public virtual Task<SignResult> SignAsync(SignatureAlgorithm algorithm, byte[] digest, CancellationToken cancellationToken = default)
        {
            SignResult result = Sign(algorithm, digest, cancellationToken);
            return Task.FromResult(result);
        }

        public virtual UnwrapResult UnwrapKey(KeyWrapAlgorithm algorithm, byte[] encryptedKey, CancellationToken cancellationToken = default)
        {
            throw ThrowOperationNotSupported(nameof(UnwrapKey));
        }

        public virtual Task<UnwrapResult> UnwrapKeyAsync(KeyWrapAlgorithm algorithm, byte[] encryptedKey, CancellationToken cancellationToken = default)
        {
            UnwrapResult result = UnwrapKey(algorithm, encryptedKey, cancellationToken);
            return Task.FromResult(result);
        }

        public virtual VerifyResult Verify(SignatureAlgorithm algorithm, byte[] digest, byte[] signature, CancellationToken cancellationToken = default)
        {
            throw ThrowOperationNotSupported(nameof(Verify));
        }

        public virtual Task<VerifyResult> VerifyAsync(SignatureAlgorithm algorithm, byte[] digest, byte[] signature, CancellationToken cancellationToken = default)
        {
            VerifyResult result = Verify(algorithm, digest, signature, cancellationToken);
            return Task.FromResult(result);
        }

        public virtual WrapResult WrapKey(KeyWrapAlgorithm algorithm, byte[] key, CancellationToken cancellationToken = default)
        {
            throw ThrowOperationNotSupported(nameof(WrapKey));
        }

        public virtual Task<WrapResult> WrapKeyAsync(KeyWrapAlgorithm algorithm, byte[] key, CancellationToken cancellationToken = default)
        {
            WrapResult result = WrapKey(algorithm, key, cancellationToken);
            return Task.FromResult(result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static NotSupportedException ThrowOperationNotSupported(string name) => new NotSupportedException($"Operation {name} not supported with the given key");

        protected void ThrowIfTimeInvalid()
        {
            if (_keyProperties != null)
            {
                DateTimeOffset now = DateTimeOffset.Now;
                if (_keyProperties.NotBefore.HasValue && now < _keyProperties.NotBefore.Value)
                {
                    throw new InvalidOperationException($"The key \"{_keyProperties.Name}\" is not valid before {_keyProperties.NotBefore.Value:r}.");
                }

                if (_keyProperties.ExpiresOn.HasValue && now > _keyProperties.ExpiresOn.Value)
                {
                    throw new InvalidOperationException($"The key \"{_keyProperties.Name}\" is not valid after {_keyProperties.ExpiresOn.Value:r}.");
                }
            }
        }
    }
}
