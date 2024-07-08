let surreal=function(){let e={$:this,plugins:[],sugar:s=>(null==s&&console.warn(`Surreal: Cannot use "${s}". Missing a character?`),s.hasOwnProperty("hasSurreal")||(s.run=t=>e.run(s,t),s.remove=()=>e.remove(s),s.classAdd=t=>e.classAdd(s,t),s.class_add=s.add_class=s.addClass=s.classAdd,s.classRemove=t=>e.classRemove(s,t),s.class_remove=s.remove_class=s.removeClass=s.classRemove,s.classToggle=t=>e.classToggle(s,t),s.class_toggle=s.toggle_class=s.toggleClass=s.classToggle,s.styles=t=>e.styles(s,t),s.on=(t,r)=>e.on(s,t,r),s.off=(t,r)=>e.off(s,t,r),s.offAll=t=>e.offAll(s,t),s.off_all=s.offAll,s.disable=()=>e.disable(s),s.enable=()=>e.enable(s),s.send=(t,r)=>e.send(s,t,r),s.trigger=s.send,s.halt=(s,t,r)=>e.halt(s,t,r),s.attribute=(t,r)=>e.attribute(s,t,r),s.attributes=s.attr=s.attribute,e.plugins.forEach(function(e){e(s)}),s.hasSurreal=1),s),me:(s=null,t=document,r=!0)=>null==s?e.sugar(t.currentScript.parentElement):s instanceof Event?s.currentTarget?e.me(s.currentTarget):(console.warn("Surreal: Event currentTarget is null. Please save your element because async will lose it"),null):"-"===s||"prev"===s||"previous"===s?e.sugar(t.currentScript.previousElementSibling):e.isSelector(s,t,r)?e.sugar(t.querySelector(s)):e.isNodeList(s)?e.me(s[0]):e.isNode(s)?e.sugar(s):null,any:(s,t=document,r=!0)=>null==s?e.sugar([t.currentScript.parentElement]):s instanceof Event?s.currentTarget?e.any(s.currentTarget):(console.warn("Surreal: Event currentTarget is null. Please save your element because async will lose it"),null):"-"===s||"prev"===s||"previous"===s?e.sugar([t.currentScript.previousElementSibling]):e.isSelector(s,t,r)?e.sugar(Array.from(t.querySelectorAll(s))):e.isNode(s)?e.sugar([s]):e.isNodeList(s)?e.sugar(Array.from(s)):null,run:(s,t)=>(e.isNodeList(s)&&s.forEach(s=>{e.run(s,t)}),e.isNode(s)&&t(s),s),remove(s){e.isNodeList(s)&&s.forEach(s=>{e.remove(s)}),e.isNode(s)&&s.parentNode.removeChild(s)},classAdd:(s,t)=>null===s||Array.isArray(s)&&0===s.length||"string"!=typeof t?null:("."===t.charAt(0)&&(t=t.substring(1)),e.isNodeList(s)&&s.forEach(s=>{e.classAdd(s,t)}),e.isNode(s)&&s.classList.add(t),s),classRemove:(s,t)=>"string"!=typeof t?null:("."===t.charAt(0)&&(t=t.substring(1)),e.isNodeList(s)&&s.forEach(s=>{e.classRemove(s,t)}),e.isNode(s)&&s.classList.remove(t),s),classToggle:(s,t)=>"string"!=typeof t?null:("."===t.charAt(0)&&(t=t.substring(1)),e.isNodeList(s)&&s.forEach(s=>{e.classToggle(s,t)}),e.isNode(s)&&s.classList.toggle(t),s),styles:(s,t)=>"string"==typeof t?(e.isNodeList(s)&&s.forEach(s=>{e.styles(s,t)}),e.isNode(s)&&e.attribute(s,"style",(null==e.attribute(s,"style")?"":e.attribute(s,"style")+"; ")+t),s):"object"==typeof t?(e.isNodeList(s)&&s.forEach(s=>{e.styles(s,t)}),e.isNode(s)&&Object.assign(s.style,t),s):void 0,on:(s,t,r)=>"string"!=typeof t?null:(e.isNodeList(s)&&s.forEach(s=>{e.on(s,t,r)}),e.isNode(s)&&s.addEventListener(t,r),s),off:(s,t,r)=>"string"!=typeof t?null:(e.isNodeList(s)&&s.forEach(s=>{e.off(s,t,r)}),e.isNode(s)&&s.removeEventListener(t,r),s),offAll:s=>(e.isNodeList(s)&&s.forEach(s=>{e.offAll(s)}),e.isNode(s)&&s.parentNode.replaceChild(s.cloneNode(!0),s),s),disable:s=>(e.isNodeList(s)&&s.forEach(s=>{e.disable(s)}),e.isNode(s)&&(s.disabled=!0),s),enable:s=>(e.isNodeList(s)&&s.forEach(s=>{e.enable(s)}),e.isNode(s)&&(s.disabled=!1),s),send(s,t,r=null){if(e.isNodeList(s)&&s.forEach(s=>{e.send(s,t,r)}),e.isNode(s)){let l=new CustomEvent(t,{detail:r,bubbles:!0});s.dispatchEvent(l)}return s},halt:(e,s=!1,t=!1)=>(e instanceof Event&&(t||e.preventDefault(),s||e.stopPropagation()),e),attribute:(s,t,r)=>"string"==typeof t&&void 0===r?e.isNodeList(s)?[]:e.isNode(s)?s.getAttribute(t):null:"string"==typeof t&&null===r?(e.isNodeList(s)&&s.forEach(s=>{e.attribute(s,t,r)}),e.isNode(s)&&s.removeAttribute(t),s):"string"==typeof t?(e.isNodeList(s)&&s.forEach(s=>{e.attribute(s,t,r)}),e.isNode(s)&&s.setAttribute(t,r),s):("object"==typeof t&&(e.isNodeList(s)&&s.forEach(s=>{Object.entries(t).forEach(([t,r])=>{e.attribute(s,t,r)})}),e.isNode(s)&&Object.entries(t).forEach(([t,r])=>{e.attribute(s,t,r)})),s),globalsAdd(){console.log("Surreal: Adding convenience globals to window.");let e=["$","sugar"];for(let[s,t]of Object.entries(this))e.includes(s)||("undefined"!=window[s]?window[s]=t:console.warn(`Surreal: "${s}()" already exists on window. Skipping to prevent overwrite.`)),window.document[s]=t},isNode:e=>!!(e instanceof HTMLElement||e instanceof SVGElement),isNodeList:e=>!!(e instanceof NodeList||Array.isArray(e)),isSelector:(e="",s=document,t=!0)=>"string"==typeof e&&(null!=s.querySelector(e)||(t&&console.warn(`Surreal: "${e}" was not found. Missing a character? (. #)`),!1))};return e.globalsAdd(),console.log("Surreal: Loaded."),e}();function pluginEffects(e){e.fadeOut=(s,t,r)=>(function e(s,t=!1,r=1e3,l=!0){let a=s;surreal.isNodeList(s)&&s.forEach(s=>{e(s,t,r)}),surreal.isNode(s)&&(async()=>{surreal.styles(s,{transform:"scale(1)",transition:`all ${r}ms ease-out`,overflow:"hidden"}),await tick(),surreal.styles(s,{transform:"scale(0.9)",opacity:"0"}),await sleep(r,s),"function"==typeof t&&t(a),l&&surreal.remove(a)})()})(e,s,t,r),e.fade_out=e.fadeOut,e.fadeIn=(s,t)=>(function e(s,t=!1,r=1e3){let l=s;surreal.isNodeList(s)&&s.forEach(s=>{e(s,t,r)}),surreal.isNode(s)&&(async()=>{let e=s.style;surreal.styles(s,{transition:`all ${r}ms ease-in`,overflow:"hidden"}),await tick(),surreal.styles(s,{opacity:"1"}),await sleep(r,s),s.style=e,surreal.styles(s,{opacity:"1"}),"function"==typeof t&&t(l)})()})(e,s,t),e.fade_in=e.fadeIn}surreal.plugins.push(pluginEffects),console.log("Surreal: Added plugins.");const createElement=create_element=document.createElement.bind(document),rAF="undefined"!=typeof requestAnimationFrame&&requestAnimationFrame,rIC="undefined"!=typeof requestIdleCallback&&requestIdleCallback;async function tick(){return await new Promise(e=>{requestAnimationFrame(e)})}async function sleep(e,s){return await new Promise(t=>setTimeout(()=>{t(s)},e))}const onloadAdd=addOnload=onload_add=add_onload=e=>{if("function"==typeof window.onload){let s=window.onload;window.onload=()=>{s(),e()};return}window.onload=e};console.log("Surreal: Added shortcuts.");