"use strict";(self.webpackChunkfurion=self.webpackChunkfurion||[]).push([[2009],{3905:function(t,e,a){a.d(e,{Zo:function(){return g},kt:function(){return u}});var n=a(7294);function r(t,e,a){return e in t?Object.defineProperty(t,e,{value:a,enumerable:!0,configurable:!0,writable:!0}):t[e]=a,t}function l(t,e){var a=Object.keys(t);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(t);e&&(n=n.filter((function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable}))),a.push.apply(a,n)}return a}function i(t){for(var e=1;e<arguments.length;e++){var a=null!=arguments[e]?arguments[e]:{};e%2?l(Object(a),!0).forEach((function(e){r(t,e,a[e])})):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(a)):l(Object(a)).forEach((function(e){Object.defineProperty(t,e,Object.getOwnPropertyDescriptor(a,e))}))}return t}function p(t,e){if(null==t)return{};var a,n,r=function(t,e){if(null==t)return{};var a,n,r={},l=Object.keys(t);for(n=0;n<l.length;n++)a=l[n],e.indexOf(a)>=0||(r[a]=t[a]);return r}(t,e);if(Object.getOwnPropertySymbols){var l=Object.getOwnPropertySymbols(t);for(n=0;n<l.length;n++)a=l[n],e.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(t,a)&&(r[a]=t[a])}return r}var d=n.createContext({}),m=function(t){var e=n.useContext(d),a=e;return t&&(a="function"==typeof t?t(e):i(i({},e),t)),a},g=function(t){var e=m(t.components);return n.createElement(d.Provider,{value:e},t.children)},k={inlineCode:"code",wrapper:function(t){var e=t.children;return n.createElement(n.Fragment,{},e)}},o=n.forwardRef((function(t,e){var a=t.components,r=t.mdxType,l=t.originalType,d=t.parentName,g=p(t,["components","mdxType","originalType","parentName"]),o=m(a),u=r,N=o["".concat(d,".").concat(u)]||o[u]||k[u]||l;return a?n.createElement(N,i(i({ref:e},g),{},{components:a})):n.createElement(N,i({ref:e},g))}));function u(t,e){var a=arguments,r=e&&e.mdxType;if("string"==typeof t||r){var l=a.length,i=new Array(l);i[0]=o;var p={};for(var d in e)hasOwnProperty.call(e,d)&&(p[d]=e[d]);p.originalType=t,p.mdxType="string"==typeof t?t:r,i[1]=p;for(var m=2;m<l;m++)i[m]=a[m];return n.createElement.apply(null,i)}return n.createElement.apply(null,a)}o.displayName="MDXCreateElement"},1695:function(t,e,a){a.r(e),a.d(e,{frontMatter:function(){return d},contentTitle:function(){return m},metadata:function(){return g},toc:function(){return k},default:function(){return u}});var n=a(3117),r=a(102),l=(a(7294),a(3905)),i=a(4996),p=["components"],d={id:"benchmark",title:"36.3 \u57fa\u51c6\u6d4b\u8bd5",sidebar_label:"36.3 \u57fa\u51c6\u6d4b\u8bd5"},m=void 0,g={unversionedId:"benchmark",id:"benchmark",isDocsHomePage:!1,title:"36.3 \u57fa\u51c6\u6d4b\u8bd5",description:"36.3.1 \u57fa\u51c6\u6d4b\u8bd5",source:"@site/docs/benchmark.mdx",sourceDirName:".",slug:"/benchmark",permalink:"/furion/docs/benchmark",editUrl:"https://gitee.com/dotnetchina/Furion/tree/master/handbook/docs/benchmark.mdx",tags:[],version:"current",lastUpdatedBy:"Monk",lastUpdatedAt:1625037063,formattedLastUpdatedAt:"6/30/2021",frontMatter:{id:"benchmark",title:"36.3 \u57fa\u51c6\u6d4b\u8bd5",sidebar_label:"36.3 \u57fa\u51c6\u6d4b\u8bd5"},sidebar:"docs",previous:{title:"36.2 \u8d1f\u8f7d\u538b\u6d4b",permalink:"/furion/docs/performance"},next:{title:"36.4 \u5e76\u53d1\u6d4b\u8bd5",permalink:"/furion/docs/bingfa"}},k=[{value:"36.3.1 \u57fa\u51c6\u6d4b\u8bd5",id:"3631-\u57fa\u51c6\u6d4b\u8bd5",children:[],level:2},{value:"36.3.2 \u57fa\u51c6\u6d4b\u8bd5\u7279\u8d28\u53ca\u610f\u4e49",id:"3632-\u57fa\u51c6\u6d4b\u8bd5\u7279\u8d28\u53ca\u610f\u4e49",children:[{value:"36.3.2.1 \u7279\u8d28",id:"36321-\u7279\u8d28",children:[],level:3},{value:"36.3.2.2 \u610f\u4e49",id:"36322-\u610f\u4e49",children:[],level:3}],level:2},{value:"36.3.3 <code>BenchmarkDotNet</code>",id:"3633-benchmarkdotnet",children:[{value:"36.3.3.1 \u5982\u4f55\u4f7f\u7528",id:"36331-\u5982\u4f55\u4f7f\u7528",children:[],level:3},{value:"36.3.3.2 \u67e5\u770b\u7ed3\u679c",id:"36332-\u67e5\u770b\u7ed3\u679c",children:[],level:3},{value:"36.3.3.3 \u5bfc\u51fa\u62a5\u8868",id:"36333-\u5bfc\u51fa\u62a5\u8868",children:[],level:3}],level:2},{value:"36.3.4 \u53cd\u9988\u4e0e\u5efa\u8bae",id:"3634-\u53cd\u9988\u4e0e\u5efa\u8bae",children:[],level:2}],o={toc:k};function u(t){var e=t.components,a=(0,r.Z)(t,p);return(0,l.kt)("wrapper",(0,n.Z)({},o,a,{components:e,mdxType:"MDXLayout"}),(0,l.kt)("h2",{id:"3631-\u57fa\u51c6\u6d4b\u8bd5"},"36.3.1 \u57fa\u51c6\u6d4b\u8bd5"),(0,l.kt)("p",null,"\u57fa\u51c6\u6d4b\u8bd5\uff08benchmarking\uff09\u662f\u4e00\u79cd\u6d4b\u91cf\u548c\u8bc4\u4f30\u8f6f\u4ef6\u6027\u80fd\u6307\u6807\u7684\u6d3b\u52a8\u3002\u4f60\u53ef\u4ee5\u5728\u67d0\u4e2a\u65f6\u5019\u901a\u8fc7\u57fa\u51c6\u6d4b\u8bd5\u5efa\u7acb\u4e00\u4e2a\u5df2\u77e5\u7684\u6027\u80fd\u6c34\u5e73\uff08\u79f0\u4e3a\u57fa\u51c6\u7ebf\uff09\uff0c\u5f53\u7cfb\u7edf\u7684\u8f6f\u786c\u4ef6\u73af\u5883\u53d1\u751f\u53d8\u5316\u4e4b\u540e\u518d\u8fdb\u884c\u4e00\u6b21\u57fa\u51c6\u6d4b\u8bd5\u4ee5\u786e\u5b9a\u90a3\u4e9b\u53d8\u5316\u5bf9\u6027\u80fd\u7684\u5f71\u54cd\u3002\u8fd9\u662f\u57fa\u51c6\u6d4b\u8bd5\u6700\u5e38\u89c1\u7684\u7528\u9014\u3002\u5176\u4ed6\u7528\u9014\u5305\u62ec\u6d4b\u5b9a\u67d0\u79cd\u8d1f\u8f7d\u6c34\u5e73\u4e0b\u7684\u6027\u80fd\u6781\u9650\u3001\u7ba1\u7406\u7cfb\u7edf\u6216\u73af\u5883\u7684\u53d8\u5316\u3001\u53d1\u73b0\u53ef\u80fd\u5bfc\u81f4\u6027\u80fd\u95ee\u9898\u7684\u6761\u4ef6\uff0c\u7b49\u7b49\u3002"),(0,l.kt)("h2",{id:"3632-\u57fa\u51c6\u6d4b\u8bd5\u7279\u8d28\u53ca\u610f\u4e49"},"36.3.2 \u57fa\u51c6\u6d4b\u8bd5\u7279\u8d28\u53ca\u610f\u4e49"),(0,l.kt)("h3",{id:"36321-\u7279\u8d28"},"36.3.2.1 \u7279\u8d28"),(0,l.kt)("ul",null,(0,l.kt)("li",{parentName:"ul"},(0,l.kt)("strong",{parentName:"li"},"\u53ef\u91cd\u590d\u6027"),"\uff1a\u53ef\u8fdb\u884c\u91cd\u590d\u6027\u7684\u6d4b\u8bd5\uff0c\u8fd9\u6837\u505a\u6709\u5229\u4e8e\u6bd4\u8f83\u6bcf\u6b21\u7684\u6d4b\u8bd5\u7ed3\u679c\uff0c\u5f97\u5230\u6027\u80fd\u7ed3\u679c\u7684\u957f\u671f\u53d8\u5316\u8d8b\u52bf\uff0c\u4e3a\u7cfb\u7edf\u8c03\u4f18\u548c\u4e0a\u7ebf\u524d\u7684\u5bb9\u91cf\u89c4\u5212\u505a\u53c2\u8003\u3002"),(0,l.kt)("li",{parentName:"ul"},(0,l.kt)("strong",{parentName:"li"},"\u53ef\u89c2\u6d4b\u6027"),"\uff1a\u901a\u8fc7\u5168\u65b9\u4f4d\u7684\u76d1\u63a7\uff08\u5305\u62ec\u6d4b\u8bd5\u5f00\u59cb\u5230\u7ed3\u675f\uff0c\u6267\u884c\u673a\u3001\u670d\u52a1\u5668\u3001\u6570\u636e\u5e93\uff09\uff0c\u53ca\u65f6\u4e86\u89e3\u548c\u5206\u6790\u6d4b\u8bd5\u8fc7\u7a0b\u53d1\u751f\u4e86\u4ec0\u4e48\u3002"),(0,l.kt)("li",{parentName:"ul"},(0,l.kt)("strong",{parentName:"li"},"\u53ef\u5c55\u793a\u6027"),"\uff1a\u76f8\u5173\u4eba\u5458\u53ef\u4ee5\u76f4\u89c2\u660e\u4e86\u7684\u4e86\u89e3\u6d4b\u8bd5\u7ed3\u679c\uff08web \u754c\u9762\u3001\u4eea\u8868\u76d8\u3001\u6298\u7ebf\u56fe\u6811\u72b6\u56fe\u7b49\u5f62\u5f0f\uff09\u3002"),(0,l.kt)("li",{parentName:"ul"},(0,l.kt)("strong",{parentName:"li"},"\u771f\u5b9e\u6027"),"\uff1a\u6d4b\u8bd5\u7684\u7ed3\u679c\u53cd\u6620\u4e86\u5ba2\u6237\u4f53\u9a8c\u5230\u7684\u771f\u5b9e\u7684\u60c5\u51b5\uff08\u771f\u5b9e\u51c6\u786e\u7684\u4e1a\u52a1\u573a\u666f+\u4e0e\u751f\u4ea7\u4e00\u81f4\u7684\u914d\u7f6e+\u5408\u7406\u6b63\u786e\u7684\u6d4b\u8bd5\u65b9\u6cd5\uff09\u3002"),(0,l.kt)("li",{parentName:"ul"},(0,l.kt)("strong",{parentName:"li"},"\u53ef\u6267\u884c\u6027"),"\uff1a\u76f8\u5173\u4eba\u5458\u53ef\u4ee5\u5feb\u901f\u7684\u8fdb\u884c\u6d4b\u8bd5\u9a8c\u8bc1\u4fee\u6539\u8c03\u4f18\uff08\u53ef\u5b9a\u4f4d\u53ef\u5206\u6790\uff09\u3002")),(0,l.kt)("h3",{id:"36322-\u610f\u4e49"},"36.3.2.2 \u610f\u4e49"),(0,l.kt)("ul",null,(0,l.kt)("li",{parentName:"ul"},"\u4e3a\u5bb9\u91cf\u89c4\u5212\u786e\u5b9a\u7cfb\u7edf\u548c\u5e94\u7528\u7a0b\u5e8f\u7684\u6781\u9650\uff1b"),(0,l.kt)("li",{parentName:"ul"},"\u4e3a\u914d\u7f6e\u6d4b\u8bd5\u7684\u53c2\u6570\u548c\u914d\u7f6e\u9009\u9879\u63d0\u4f9b\u53c2\u8003\u4f9d\u636e\uff1b"),(0,l.kt)("li",{parentName:"ul"},"\u4e3a\u9a8c\u6536\u6d4b\u8bd5\u786e\u5b9a\u7cfb\u7edf\u662f\u5426\u5177\u5907\u81ea\u5df1\u6240\u5ba3\u79f0\u7684\u80fd\u529b\uff1b"),(0,l.kt)("li",{parentName:"ul"},"\u4e3a\u6027\u80fd\u57fa\u7ebf\u7684\u5efa\u7acb\u63d0\u4f9b\u957f\u671f\u7684\u6570\u636e\u7edf\u8ba1\u6765\u6e90\u4ee5\u53ca\u6bd4\u8f83\u57fa\u51c6\uff1b")),(0,l.kt)("h2",{id:"3633-benchmarkdotnet"},"36.3.3 ",(0,l.kt)("inlineCode",{parentName:"h2"},"BenchmarkDotNet")),(0,l.kt)("p",null,(0,l.kt)("inlineCode",{parentName:"p"},"BenchmarkDotNet")," \u662f ",(0,l.kt)("inlineCode",{parentName:"p"},".NET")," \u5e73\u53f0\u63d0\u4f9b\u7684\u57fa\u51c6\u6d4b\u8bd5\u5de5\u5177\uff0c",(0,l.kt)("inlineCode",{parentName:"p"},"BenchmarkDotNet")," \u53ef\u5e2e\u52a9\u60a8\u5c06\u65b9\u6cd5\u8f6c\u6362\u4e3a\u57fa\u51c6\uff0c\u8ddf\u8e2a\u5176\u6027\u80fd\uff0c\u5e76\u5171\u4eab\u53ef\u91cd\u590d\u7684\u6d4b\u91cf\u5b9e\u9a8c\u3002",(0,l.kt)("inlineCode",{parentName:"p"},"BenchmarkDotNet")," \u53ef\u4fdd\u62a4\u60a8\u514d\u53d7\u6d41\u884c\u7684\u57fa\u51c6\u6d4b\u8bd5\u9519\u8bef\uff0c\u5e76\u5728\u57fa\u51c6\u8bbe\u8ba1\u6216\u83b7\u5f97\u7684\u6d4b\u91cf\u4e2d\u51fa\u73b0\u95ee\u9898\u65f6\u8b66\u544a\u60a8\u3002\u7ed3\u679c\u4ee5\u7528\u6237\u53cb\u597d\u7684\u5f62\u5f0f\u5448\u73b0\uff0c\u7a81\u51fa\u663e\u793a\u4e86\u6709\u5173\u5b9e\u9a8c\u7684\u6240\u6709\u91cd\u8981\u4e8b\u5b9e\u3002"),(0,l.kt)("h3",{id:"36331-\u5982\u4f55\u4f7f\u7528"},"36.3.3.1 \u5982\u4f55\u4f7f\u7528"),(0,l.kt)("p",null,"\u521b\u5efa\u4e00\u4e2a ",(0,l.kt)("inlineCode",{parentName:"p"},"\u63a7\u5236\u53f0")," \u5e94\u7528\u7a0b\u5e8f\uff0c\u5e76\u901a\u8fc7 ",(0,l.kt)("inlineCode",{parentName:"p"},"Nuget")," \u5b89\u88c5 ",(0,l.kt)("a",{parentName:"p",href:"https://www.nuget.org/packages/BenchmarkDotNet/"},"BenchmarkDotNet")," \u62d3\u5c55\u5305\u3002\u7f16\u5199\u6d4b\u8bd5\uff1a"),(0,l.kt)("pre",null,(0,l.kt)("code",{parentName:"pre",className:"language-cs",metastring:"{3-4,22,25,33}","{3-4,22,25,33}":!0},"using System;\nusing System.Security.Cryptography;\nusing BenchmarkDotNet.Attributes;\nusing BenchmarkDotNet.Running;\n\nnamespace MyBenchmarks\n{\n    public class Md5VsSha256\n    {\n        private const int N = 10000;\n        private readonly byte[] data;\n\n        private readonly SHA256 sha256 = SHA256.Create();\n        private readonly MD5 md5 = MD5.Create();\n\n        public Md5VsSha256()\n        {\n            data = new byte[N];\n            new Random(42).NextBytes(data);\n        }\n\n        [Benchmark]\n        public byte[] Sha256() => sha256.ComputeHash(data);\n\n        [Benchmark]\n        public byte[] Md5() => md5.ComputeHash(data);\n    }\n\n    public class Program\n    {\n        public static void Main(string[] args)\n        {\n            var summary = BenchmarkRunner.Run<Md5VsSha256>();\n        }\n    }\n}\n")),(0,l.kt)("h3",{id:"36332-\u67e5\u770b\u7ed3\u679c"},"36.3.3.2 \u67e5\u770b\u7ed3\u679c"),(0,l.kt)("p",null,"\u8fd0\u884c\u63a7\u5236\u5668\u7a0b\u5e8f\uff0c\u5c06\u5f97\u5230\u4ee5\u4e0b\u7ed3\u679c"),(0,l.kt)("pre",null,(0,l.kt)("code",{parentName:"pre"},"BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.805 (1809/October2018Update/Redstone5)\nIntel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores\n  [Host]       : .NET Framework 4.7.2 (4.7.3468.0), X64 RyuJIT\n  Net472       : .NET Framework 4.7.2 (4.7.3468.0), X64 RyuJIT\n  NetCoreApp30 : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT\n  CoreRt30     : .NET CoreRT 1.0.28236.02 @Commit: 741d61493c560ba96e8151f9e56876d4d3828489, X64 AOT\n  Mono         : Mono 6.4.0 (Visual Studio), X64\n")),(0,l.kt)("table",null,(0,l.kt)("thead",{parentName:"table"},(0,l.kt)("tr",{parentName:"thead"},(0,l.kt)("th",{parentName:"tr",align:null},"Method"),(0,l.kt)("th",{parentName:"tr",align:null},"Runtime"),(0,l.kt)("th",{parentName:"tr",align:null},"N"),(0,l.kt)("th",{parentName:"tr",align:"right"},"Mean"),(0,l.kt)("th",{parentName:"tr",align:"right"},"Error"),(0,l.kt)("th",{parentName:"tr",align:"right"},"StdDev"),(0,l.kt)("th",{parentName:"tr",align:"right"},"Ratio"))),(0,l.kt)("tbody",{parentName:"table"},(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Sha256"),(0,l.kt)("td",{parentName:"tr",align:null},".NET 4.7.2"),(0,l.kt)("td",{parentName:"tr",align:null},"1000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"7.735 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.1913 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.4034 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.00")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Sha256"),(0,l.kt)("td",{parentName:"tr",align:null},".NET Core 3.0"),(0,l.kt)("td",{parentName:"tr",align:null},"1000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"3.989 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0796 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0745 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.50")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Sha256"),(0,l.kt)("td",{parentName:"tr",align:null},"CoreRt 3.0"),(0,l.kt)("td",{parentName:"tr",align:null},"1000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"4.091 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0811 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.1562 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.53")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Sha256"),(0,l.kt)("td",{parentName:"tr",align:null},"Mono"),(0,l.kt)("td",{parentName:"tr",align:null},"1000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"13.117 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.2485 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.5019 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.70")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"})),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Md5"),(0,l.kt)("td",{parentName:"tr",align:null},".NET 4.7.2"),(0,l.kt)("td",{parentName:"tr",align:null},"1000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"2.872 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0552 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0737 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.00")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Md5"),(0,l.kt)("td",{parentName:"tr",align:null},".NET Core 3.0"),(0,l.kt)("td",{parentName:"tr",align:null},"1000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.848 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0348 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0326 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.64")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Md5"),(0,l.kt)("td",{parentName:"tr",align:null},"CoreRt 3.0"),(0,l.kt)("td",{parentName:"tr",align:null},"1000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.817 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0359 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0427 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.63")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Md5"),(0,l.kt)("td",{parentName:"tr",align:null},"Mono"),(0,l.kt)("td",{parentName:"tr",align:null},"1000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"3.574 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0678 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.0753 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.24")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"})),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Sha256"),(0,l.kt)("td",{parentName:"tr",align:null},".NET 4.7.2"),(0,l.kt)("td",{parentName:"tr",align:null},"10000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"74.509 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.5787 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"4.6052 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.00")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Sha256"),(0,l.kt)("td",{parentName:"tr",align:null},".NET Core 3.0"),(0,l.kt)("td",{parentName:"tr",align:null},"10000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"36.049 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.7151 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.0025 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.49")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Sha256"),(0,l.kt)("td",{parentName:"tr",align:null},"CoreRt 3.0"),(0,l.kt)("td",{parentName:"tr",align:null},"10000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"36.253 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.7076 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.7571 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.49")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Sha256"),(0,l.kt)("td",{parentName:"tr",align:null},"Mono"),(0,l.kt)("td",{parentName:"tr",align:null},"10000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"116.350 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"2.2555 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"3.0110 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.58")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:null}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"}),(0,l.kt)("td",{parentName:"tr",align:"right"})),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Md5"),(0,l.kt)("td",{parentName:"tr",align:null},".NET 4.7.2"),(0,l.kt)("td",{parentName:"tr",align:null},"10000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"17.308 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.3361 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.4250 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.00")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Md5"),(0,l.kt)("td",{parentName:"tr",align:null},".NET Core 3.0"),(0,l.kt)("td",{parentName:"tr",align:null},"10000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"15.726 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.2064 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.1930 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.90")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Md5"),(0,l.kt)("td",{parentName:"tr",align:null},"CoreRt 3.0"),(0,l.kt)("td",{parentName:"tr",align:null},"10000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"15.627 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.2631 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.2461 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.89")),(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:null},"Md5"),(0,l.kt)("td",{parentName:"tr",align:null},"Mono"),(0,l.kt)("td",{parentName:"tr",align:null},"10000"),(0,l.kt)("td",{parentName:"tr",align:"right"},"30.205 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.5868 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"0.6522 us"),(0,l.kt)("td",{parentName:"tr",align:"right"},"1.74")))),(0,l.kt)("h3",{id:"36333-\u5bfc\u51fa\u62a5\u8868"},"36.3.3.3 \u5bfc\u51fa\u62a5\u8868"),(0,l.kt)("p",null,"\u4e5f\u53ef\u4ee5\u5bfc\u51fa\u5404\u79cd\u56fe\u8868"),(0,l.kt)("img",{src:(0,i.Z)("img/bm1.png")}),(0,l.kt)("h2",{id:"3634-\u53cd\u9988\u4e0e\u5efa\u8bae"},"36.3.4 \u53cd\u9988\u4e0e\u5efa\u8bae"),(0,l.kt)("div",{className:"admonition admonition-note alert alert--secondary"},(0,l.kt)("div",{parentName:"div",className:"admonition-heading"},(0,l.kt)("h5",{parentName:"div"},(0,l.kt)("span",{parentName:"h5",className:"admonition-icon"},(0,l.kt)("svg",{parentName:"span",xmlns:"http://www.w3.org/2000/svg",width:"14",height:"16",viewBox:"0 0 14 16"},(0,l.kt)("path",{parentName:"svg",fillRule:"evenodd",d:"M6.3 5.69a.942.942 0 0 1-.28-.7c0-.28.09-.52.28-.7.19-.18.42-.28.7-.28.28 0 .52.09.7.28.18.19.28.42.28.7 0 .28-.09.52-.28.7a1 1 0 0 1-.7.3c-.28 0-.52-.11-.7-.3zM8 7.99c-.02-.25-.11-.48-.31-.69-.2-.19-.42-.3-.69-.31H6c-.27.02-.48.13-.69.31-.2.2-.3.44-.31.69h1v3c.02.27.11.5.31.69.2.2.42.31.69.31h1c.27 0 .48-.11.69-.31.2-.19.3-.42.31-.69H8V7.98v.01zM7 2.3c-3.14 0-5.7 2.54-5.7 5.68 0 3.14 2.56 5.7 5.7 5.7s5.7-2.55 5.7-5.7c0-3.15-2.56-5.69-5.7-5.69v.01zM7 .98c3.86 0 7 3.14 7 7s-3.14 7-7 7-7-3.12-7-7 3.14-7 7-7z"}))),"\u4e0e\u6211\u4eec\u4ea4\u6d41")),(0,l.kt)("div",{parentName:"div",className:"admonition-content"},(0,l.kt)("p",{parentName:"div"},"\u7ed9 Furion \u63d0 ",(0,l.kt)("a",{parentName:"p",href:"https://gitee.com/dotnetchina/Furion/issues/new?issue"},"Issue"),"\u3002"))),(0,l.kt)("hr",null),(0,l.kt)("div",{className:"admonition admonition-note alert alert--secondary"},(0,l.kt)("div",{parentName:"div",className:"admonition-heading"},(0,l.kt)("h5",{parentName:"div"},(0,l.kt)("span",{parentName:"h5",className:"admonition-icon"},(0,l.kt)("svg",{parentName:"span",xmlns:"http://www.w3.org/2000/svg",width:"14",height:"16",viewBox:"0 0 14 16"},(0,l.kt)("path",{parentName:"svg",fillRule:"evenodd",d:"M6.3 5.69a.942.942 0 0 1-.28-.7c0-.28.09-.52.28-.7.19-.18.42-.28.7-.28.28 0 .52.09.7.28.18.19.28.42.28.7 0 .28-.09.52-.28.7a1 1 0 0 1-.7.3c-.28 0-.52-.11-.7-.3zM8 7.99c-.02-.25-.11-.48-.31-.69-.2-.19-.42-.3-.69-.31H6c-.27.02-.48.13-.69.31-.2.2-.3.44-.31.69h1v3c.02.27.11.5.31.69.2.2.42.31.69.31h1c.27 0 .48-.11.69-.31.2-.19.3-.42.31-.69H8V7.98v.01zM7 2.3c-3.14 0-5.7 2.54-5.7 5.68 0 3.14 2.56 5.7 5.7 5.7s5.7-2.55 5.7-5.7c0-3.15-2.56-5.69-5.7-5.69v.01zM7 .98c3.86 0 7 3.14 7 7s-3.14 7-7 7-7-3.12-7-7 3.14-7 7-7z"}))),"\u4e86\u89e3\u66f4\u591a")),(0,l.kt)("div",{parentName:"div",className:"admonition-content"},(0,l.kt)("p",{parentName:"div"},"\u60f3\u4e86\u89e3\u66f4\u591a ",(0,l.kt)("inlineCode",{parentName:"p"},"BenchmarkDotNet")," \u77e5\u8bc6\u53ef\u67e5\u9605 ",(0,l.kt)("a",{parentName:"p",href:"https://benchmarkdotnet.org/"},"BenchmarkDotNet \u5b98\u7f51"),"\u3002"))))}u.isMDXComponent=!0}}]);