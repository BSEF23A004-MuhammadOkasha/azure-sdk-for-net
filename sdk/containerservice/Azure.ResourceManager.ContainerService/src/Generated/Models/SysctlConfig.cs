// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Sysctl settings for Linux agent nodes. </summary>
    public partial class SysctlConfig
    {
        /// <summary> Initializes a new instance of SysctlConfig. </summary>
        public SysctlConfig()
        {
        }

        /// <summary> Initializes a new instance of SysctlConfig. </summary>
        /// <param name="netCoreSomaxconn"> Sysctl setting net.core.somaxconn. </param>
        /// <param name="netCoreNetdevMaxBacklog"> Sysctl setting net.core.netdev_max_backlog. </param>
        /// <param name="netCoreRmemDefault"> Sysctl setting net.core.rmem_default. </param>
        /// <param name="netCoreRmemMax"> Sysctl setting net.core.rmem_max. </param>
        /// <param name="netCoreWmemDefault"> Sysctl setting net.core.wmem_default. </param>
        /// <param name="netCoreWmemMax"> Sysctl setting net.core.wmem_max. </param>
        /// <param name="netCoreOptmemMax"> Sysctl setting net.core.optmem_max. </param>
        /// <param name="netIPv4TcpMaxSynBacklog"> Sysctl setting net.ipv4.tcp_max_syn_backlog. </param>
        /// <param name="netIPv4TcpMaxTwBuckets"> Sysctl setting net.ipv4.tcp_max_tw_buckets. </param>
        /// <param name="netIPv4TcpFinTimeout"> Sysctl setting net.ipv4.tcp_fin_timeout. </param>
        /// <param name="netIPv4TcpKeepaliveTime"> Sysctl setting net.ipv4.tcp_keepalive_time. </param>
        /// <param name="netIPv4TcpKeepaliveProbes"> Sysctl setting net.ipv4.tcp_keepalive_probes. </param>
        /// <param name="netIPv4TcpKeepaliveIntvl"> Sysctl setting net.ipv4.tcp_keepalive_intvl. </param>
        /// <param name="netIPv4TcpTwReuse"> Sysctl setting net.ipv4.tcp_tw_reuse. </param>
        /// <param name="netIPv4IPLocalPortRange"> Sysctl setting net.ipv4.ip_local_port_range. </param>
        /// <param name="netIPv4NeighDefaultGcThresh1"> Sysctl setting net.ipv4.neigh.default.gc_thresh1. </param>
        /// <param name="netIPv4NeighDefaultGcThresh2"> Sysctl setting net.ipv4.neigh.default.gc_thresh2. </param>
        /// <param name="netIPv4NeighDefaultGcThresh3"> Sysctl setting net.ipv4.neigh.default.gc_thresh3. </param>
        /// <param name="netNetfilterNfConntrackMax"> Sysctl setting net.netfilter.nf_conntrack_max. </param>
        /// <param name="netNetfilterNfConntrackBuckets"> Sysctl setting net.netfilter.nf_conntrack_buckets. </param>
        /// <param name="fsInotifyMaxUserWatches"> Sysctl setting fs.inotify.max_user_watches. </param>
        /// <param name="fsFileMax"> Sysctl setting fs.file-max. </param>
        /// <param name="fsAioMaxNr"> Sysctl setting fs.aio-max-nr. </param>
        /// <param name="fsNrOpen"> Sysctl setting fs.nr_open. </param>
        /// <param name="kernelThreadsMax"> Sysctl setting kernel.threads-max. </param>
        /// <param name="vmMaxMapCount"> Sysctl setting vm.max_map_count. </param>
        /// <param name="vmSwappiness"> Sysctl setting vm.swappiness. </param>
        /// <param name="vmVfsCachePressure"> Sysctl setting vm.vfs_cache_pressure. </param>
        internal SysctlConfig(int? netCoreSomaxconn, int? netCoreNetdevMaxBacklog, int? netCoreRmemDefault, int? netCoreRmemMax, int? netCoreWmemDefault, int? netCoreWmemMax, int? netCoreOptmemMax, int? netIPv4TcpMaxSynBacklog, int? netIPv4TcpMaxTwBuckets, int? netIPv4TcpFinTimeout, int? netIPv4TcpKeepaliveTime, int? netIPv4TcpKeepaliveProbes, int? netIPv4TcpKeepaliveIntvl, bool? netIPv4TcpTwReuse, string netIPv4IPLocalPortRange, int? netIPv4NeighDefaultGcThresh1, int? netIPv4NeighDefaultGcThresh2, int? netIPv4NeighDefaultGcThresh3, int? netNetfilterNfConntrackMax, int? netNetfilterNfConntrackBuckets, int? fsInotifyMaxUserWatches, int? fsFileMax, int? fsAioMaxNr, int? fsNrOpen, int? kernelThreadsMax, int? vmMaxMapCount, int? vmSwappiness, int? vmVfsCachePressure)
        {
            NetCoreSomaxconn = netCoreSomaxconn;
            NetCoreNetdevMaxBacklog = netCoreNetdevMaxBacklog;
            NetCoreRmemDefault = netCoreRmemDefault;
            NetCoreRmemMax = netCoreRmemMax;
            NetCoreWmemDefault = netCoreWmemDefault;
            NetCoreWmemMax = netCoreWmemMax;
            NetCoreOptmemMax = netCoreOptmemMax;
            NetIPv4TcpMaxSynBacklog = netIPv4TcpMaxSynBacklog;
            NetIPv4TcpMaxTwBuckets = netIPv4TcpMaxTwBuckets;
            NetIPv4TcpFinTimeout = netIPv4TcpFinTimeout;
            NetIPv4TcpKeepaliveTime = netIPv4TcpKeepaliveTime;
            NetIPv4TcpKeepaliveProbes = netIPv4TcpKeepaliveProbes;
            NetIPv4TcpKeepaliveIntvl = netIPv4TcpKeepaliveIntvl;
            NetIPv4TcpTwReuse = netIPv4TcpTwReuse;
            NetIPv4IPLocalPortRange = netIPv4IPLocalPortRange;
            NetIPv4NeighDefaultGcThresh1 = netIPv4NeighDefaultGcThresh1;
            NetIPv4NeighDefaultGcThresh2 = netIPv4NeighDefaultGcThresh2;
            NetIPv4NeighDefaultGcThresh3 = netIPv4NeighDefaultGcThresh3;
            NetNetfilterNfConntrackMax = netNetfilterNfConntrackMax;
            NetNetfilterNfConntrackBuckets = netNetfilterNfConntrackBuckets;
            FsInotifyMaxUserWatches = fsInotifyMaxUserWatches;
            FsFileMax = fsFileMax;
            FsAioMaxNr = fsAioMaxNr;
            FsNrOpen = fsNrOpen;
            KernelThreadsMax = kernelThreadsMax;
            VmMaxMapCount = vmMaxMapCount;
            VmSwappiness = vmSwappiness;
            VmVfsCachePressure = vmVfsCachePressure;
        }

        /// <summary> Sysctl setting net.core.somaxconn. </summary>
        public int? NetCoreSomaxconn { get; set; }
        /// <summary> Sysctl setting net.core.netdev_max_backlog. </summary>
        public int? NetCoreNetdevMaxBacklog { get; set; }
        /// <summary> Sysctl setting net.core.rmem_default. </summary>
        public int? NetCoreRmemDefault { get; set; }
        /// <summary> Sysctl setting net.core.rmem_max. </summary>
        public int? NetCoreRmemMax { get; set; }
        /// <summary> Sysctl setting net.core.wmem_default. </summary>
        public int? NetCoreWmemDefault { get; set; }
        /// <summary> Sysctl setting net.core.wmem_max. </summary>
        public int? NetCoreWmemMax { get; set; }
        /// <summary> Sysctl setting net.core.optmem_max. </summary>
        public int? NetCoreOptmemMax { get; set; }
        /// <summary> Sysctl setting net.ipv4.tcp_max_syn_backlog. </summary>
        public int? NetIPv4TcpMaxSynBacklog { get; set; }
        /// <summary> Sysctl setting net.ipv4.tcp_max_tw_buckets. </summary>
        public int? NetIPv4TcpMaxTwBuckets { get; set; }
        /// <summary> Sysctl setting net.ipv4.tcp_fin_timeout. </summary>
        public int? NetIPv4TcpFinTimeout { get; set; }
        /// <summary> Sysctl setting net.ipv4.tcp_keepalive_time. </summary>
        public int? NetIPv4TcpKeepaliveTime { get; set; }
        /// <summary> Sysctl setting net.ipv4.tcp_keepalive_probes. </summary>
        public int? NetIPv4TcpKeepaliveProbes { get; set; }
        /// <summary> Sysctl setting net.ipv4.tcp_keepalive_intvl. </summary>
        public int? NetIPv4TcpKeepaliveIntvl { get; set; }
        /// <summary> Sysctl setting net.ipv4.tcp_tw_reuse. </summary>
        public bool? NetIPv4TcpTwReuse { get; set; }
        /// <summary> Sysctl setting net.ipv4.ip_local_port_range. </summary>
        public string NetIPv4IPLocalPortRange { get; set; }
        /// <summary> Sysctl setting net.ipv4.neigh.default.gc_thresh1. </summary>
        public int? NetIPv4NeighDefaultGcThresh1 { get; set; }
        /// <summary> Sysctl setting net.ipv4.neigh.default.gc_thresh2. </summary>
        public int? NetIPv4NeighDefaultGcThresh2 { get; set; }
        /// <summary> Sysctl setting net.ipv4.neigh.default.gc_thresh3. </summary>
        public int? NetIPv4NeighDefaultGcThresh3 { get; set; }
        /// <summary> Sysctl setting net.netfilter.nf_conntrack_max. </summary>
        public int? NetNetfilterNfConntrackMax { get; set; }
        /// <summary> Sysctl setting net.netfilter.nf_conntrack_buckets. </summary>
        public int? NetNetfilterNfConntrackBuckets { get; set; }
        /// <summary> Sysctl setting fs.inotify.max_user_watches. </summary>
        public int? FsInotifyMaxUserWatches { get; set; }
        /// <summary> Sysctl setting fs.file-max. </summary>
        public int? FsFileMax { get; set; }
        /// <summary> Sysctl setting fs.aio-max-nr. </summary>
        public int? FsAioMaxNr { get; set; }
        /// <summary> Sysctl setting fs.nr_open. </summary>
        public int? FsNrOpen { get; set; }
        /// <summary> Sysctl setting kernel.threads-max. </summary>
        public int? KernelThreadsMax { get; set; }
        /// <summary> Sysctl setting vm.max_map_count. </summary>
        public int? VmMaxMapCount { get; set; }
        /// <summary> Sysctl setting vm.swappiness. </summary>
        public int? VmSwappiness { get; set; }
        /// <summary> Sysctl setting vm.vfs_cache_pressure. </summary>
        public int? VmVfsCachePressure { get; set; }
    }
}
