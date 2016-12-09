/*
 AngularJS v1.2.0-rc.2
 (c) 2010-2012 Google, Inc. http://angularjs.org
 License: MIT
*/
(function(H,g,C){'use strict';var A=g.$$minErr("$resource");g.module("ngResource",["ng"]).factory("$resource",["$http","$parse","$q",function(D,y,E){function n(g,h){this.template=g;this.defaults=h||{};this.urlParams={}}function u(l,h,d){function p(c,b){var e={};b=v({},h,b);q(b,function(a,b){t(a)&&(a=a());var m;a&&a.charAt&&"@"==a.charAt(0)?(m=a.substr(1),m=y(m)(c)):m=a;e[b]=m});return e}function b(c){return c.resource}function e(c){z(c||{},this)}var F=new n(l);d=v({},G,d);q(d,function(c,f){var h=
/^(POST|PUT|PATCH)$/i.test(c.method);e[f]=function(a,f,m,l){var d={},r,s,w;switch(arguments.length){case 4:w=l,s=m;case 3:case 2:if(t(f)){if(t(a)){s=a;w=f;break}s=f;w=m}else{d=a;r=f;s=m;break}case 1:t(a)?s=a:h?r=a:d=a;break;case 0:break;default:throw A("badargs",arguments.length);}var n=r instanceof e,k=n?r:c.isArray?[]:new e(r),x={},u=c.interceptor&&c.interceptor.response||b,y=c.interceptor&&c.interceptor.responseError||C;q(c,function(a,c){"params"!=c&&("isArray"!=c&&"interceptor"!=c)&&(x[c]=z(a))});
x.data=r;F.setUrlParams(x,v({},p(r,c.params||{}),d),c.url);d=D(x).then(function(a){var b=a.data,f=k.$promise;if(b){if(g.isArray(b)!=!!c.isArray)throw A("badcfg",c.isArray?"array":"object",g.isArray(b)?"array":"object");c.isArray?(k.length=0,q(b,function(a){k.push(new e(a))})):(z(b,k),k.$promise=f)}k.$resolved=!0;(s||B)(k,a.headers);a.resource=k;return a},function(a){k.$resolved=!0;(w||B)(a);return E.reject(a)}).then(u,y);return n?d:(k.$promise=d,k.$resolved=!1,k)};e.prototype["$"+f]=function(a,c,
b){t(a)&&(b=c,c=a,a={});a=e[f](a,this,c,b);return a.$promise||a}});e.bind=function(c){return u(l,v({},h,c),d)};return e}var G={get:{method:"GET"},save:{method:"POST"},query:{method:"GET",isArray:!0},remove:{method:"DELETE"},"delete":{method:"DELETE"}},B=g.noop,q=g.forEach,v=g.extend,z=g.copy,t=g.isFunction;n.prototype={setUrlParams:function(l,h,d){var p=this,b=d||p.template,e,n,c=p.urlParams={};q(b.split(/\W/),function(f){!/^\d+$/.test(f)&&(f&&RegExp("(^|[^\\\\]):"+f+"(\\W|$)").test(b))&&(c[f]=!0)});
b=b.replace(/\\:/g,":");h=h||{};q(p.urlParams,function(c,d){e=h.hasOwnProperty(d)?h[d]:p.defaults[d];g.isDefined(e)&&null!==e?(n=encodeURIComponent(e).replace(/%40/gi,"@").replace(/%3A/gi,":").replace(/%24/g,"$").replace(/%2C/gi,",").replace(/%20/g,"%20").replace(/%26/gi,"&").replace(/%3D/gi,"=").replace(/%2B/gi,"+"),b=b.replace(RegExp(":"+d+"(\\W|$)","g"),n+"$1")):b=b.replace(RegExp("(/?):"+d+"(\\W|$)","g"),function(a,c,b){return"/"==b.charAt(0)?b:c+b})});b=b.replace(/\/+$/,"");b=b.replace(/\/\.(?=\w+($|\?))/,
".");l.url=b.replace(/\/\\\./,"/.");q(h,function(c,b){p.urlParams[b]||(l.params=l.params||{},l.params[b]=c)})}};return u}])})(window,window.angular);

