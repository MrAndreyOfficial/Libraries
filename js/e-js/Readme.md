# All Methods
```
import { ejs } from './ejs.js';

const h1 = document.getElementsByTagName('h1')[0];
const input = document.getElementsByTagName('input')[0];

ejs.on(h1, 'mouseenter', () => ejs.addClass(h1, 'bg-dark'));
ejs.click(h1, () => ejs.toogleClass(h1, 'bg-yellow'));

ejs.mouseenter(h1, () => console.log(ejs.getTextContent(h1)));
ejs.mouseover(h1, e => console.log(e.target.outerHTML));
ejs.mouseleave(h1, () => ejs.removeClass(h1, 'bg-yellow'));

ejs.setTextContent(h1, 'Hi!');

ejs.setInputValue(input, 'Hello World!');
console.log(ejs.getInputValue(input));

```

## How to install: 
1. Download ejs.js or clone this repository
2. Include file in html file (requires type="module" on the [script tag](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/script)) or js file
