export const ejs = {
    on: (element, event, callback) => {
        if (isHTMLElement(element)) {
            element.addEventListener(event, callback);
            return;
        }
    },
    click: (element, callback) => {
        if (isHTMLElement(element)) {
            ejs.on(element, 'click', callback);
            return;
        }
    },
    mouseenter: (element, callback) => {
        if (isHTMLElement(element)) {
            ejs.on(element, 'mouseenter', callback);
            return;
        }
    },
    mouseover: (element, callback) => {
        if (isHTMLElement(element)) {
            ejs.on(element, 'mouseover', callback);
            return;
        }
    },
    mouseleave: (element, callback) => {
        if (isHTMLElement(element)) {
            ejs.on(element, 'mouseleave', callback);
            return;
        }
    },
    addClass: (element, className) => {
        if (isHTMLElement(element)) {
            element.classList.add(className);
            return;
        }
    },
    removeClass: (element, className) => {
        if (isHTMLElement(element)) {
            element.classList.remove(className);
            return;
        }
    },
    toogleClass: (element, className) => {
        if (isHTMLElement(element)) {
            const hasClass = element.classList.contains(className);

            hasClass ? ejs.removeClass(element, className) : ejs.addClass(element, className);
        }
    },
    setTextContent: (element, textContent) => {
        if (isHTMLElement(element)) {
            element.textContent = textContent;
        }
    },
    getTextContent: (element) => {
        if (isHTMLElement(element)) {
            return element.textContent;
        }

        return null;
    },
    setInputValue: (element, value) => {
        element.value = value;
    },
    getInputValue: (element) => {
        return element.value;
    }
};

function isHTMLElement(element) {
    return element instanceof HTMLElement;
}
