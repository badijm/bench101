## .NET Framework 4.7.2 (4.7.3062.0), X64 RyuJIT
```assembly
; bench.core.Intrinsics.VectorizationBenchmark.CustomMul()
       sub       rsp,28
       movaps    [rsp+10],xmm6
       movaps    [rsp],xmm7
       lea       rax,[rcx+38]
       movss     xmm0,dword ptr [rax]
       movss     xmm1,dword ptr [rax+4]
       movss     xmm2,dword ptr [rax+8]
       movss     xmm3,dword ptr [rax+0C]
       lea       rax,[rcx+48]
       movss     xmm4,dword ptr [rax]
       movss     xmm5,dword ptr [rax+4]
       movss     xmm6,dword ptr [rax+8]
       movss     xmm7,dword ptr [rax+0C]
       mulss     xmm0,xmm4
       mulss     xmm1,xmm5
       mulss     xmm2,xmm6
       mulss     xmm3,xmm7
       lea       rax,[rcx+58]
       movss     dword ptr [rax],xmm0
       movss     dword ptr [rax+4],xmm1
       movss     dword ptr [rax+8],xmm2
       movss     dword ptr [rax+0C],xmm3
       movaps    xmm6,[rsp+10]
       movaps    xmm7,[rsp]
       add       rsp,28
       ret
; Total bytes of code 112
```

## .NET Framework 4.7.2 (4.7.3062.0), X64 RyuJIT
```assembly
; bench.core.Intrinsics.VectorizationBenchmark.SystemMul()
       movups    xmm0,[rcx+8]
       movups    xmm1,[rcx+18]
       mulps     xmm0,xmm1
       movups    [rcx+28],xmm0
       ret
; Total bytes of code 16
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; bench.core.Intrinsics.VectorizationBenchmark.CustomMul()
       sub       rsp,28
       vzeroupper
       vmovaps   [rsp+10],xmm6
       vmovaps   [rsp],xmm7
       lea       rax,[rcx+38]
       vmovss    xmm0,dword ptr [rax]
       vmovss    xmm1,dword ptr [rax+4]
       vmovss    xmm2,dword ptr [rax+8]
       vmovss    xmm3,dword ptr [rax+0C]
       lea       rax,[rcx+48]
       vmovss    xmm4,dword ptr [rax]
       vmovss    xmm5,dword ptr [rax+4]
       vmovss    xmm6,dword ptr [rax+8]
       vmovss    xmm7,dword ptr [rax+0C]
       vmulss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm1,xmm5
       vmulss    xmm2,xmm2,xmm6
       vmulss    xmm3,xmm3,xmm7
       add       rcx,58
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm1
       vmovss    dword ptr [rcx+8],xmm2
       vmovss    dword ptr [rcx+0C],xmm3
       vmovaps   xmm6,[rsp+10]
       vmovaps   xmm7,[rsp]
       add       rsp,28
       ret
; Total bytes of code 119
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; bench.core.Intrinsics.VectorizationBenchmark.SystemMul()
       vzeroupper
       vmovupd   xmm0,[rcx+8]
       vmovupd   xmm1,[rcx+18]
       vmulps    xmm0,xmm0,xmm1
       vmovupd   [rcx+28],xmm0
       ret
; Total bytes of code 23
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; bench.core.Intrinsics.VectorizationBenchmark.CustomMul()
       sub       rsp,28
       vzeroupper
       vmovaps   [rsp+10],xmm6
       vmovaps   [rsp],xmm7
       lea       rax,[rcx+38]
       vmovss    xmm0,dword ptr [rax]
       vmovss    xmm1,dword ptr [rax+4]
       vmovss    xmm2,dword ptr [rax+8]
       vmovss    xmm3,dword ptr [rax+0C]
       lea       rax,[rcx+48]
       vmovss    xmm4,dword ptr [rax]
       vmovss    xmm5,dword ptr [rax+4]
       vmovss    xmm6,dword ptr [rax+8]
       vmovss    xmm7,dword ptr [rax+0C]
       vmulss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm1,xmm5
       vmulss    xmm2,xmm2,xmm6
       vmulss    xmm3,xmm3,xmm7
       add       rcx,58
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm1
       vmovss    dword ptr [rcx+8],xmm2
       vmovss    dword ptr [rcx+0C],xmm3
       vmovaps   xmm6,[rsp+10]
       vmovaps   xmm7,[rsp]
       add       rsp,28
       ret
; Total bytes of code 119
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; bench.core.Intrinsics.VectorizationBenchmark.SystemMul()
       vzeroupper
       vmovupd   xmm0,[rcx+8]
       vmovupd   xmm1,[rcx+18]
       vmulps    xmm0,xmm0,xmm1
       vmovupd   [rcx+28],xmm0
       ret
; Total bytes of code 23
```
