export function getCookie(key: string) {
    const b = document.cookie.match("(ˆ|;)\\s*" + key + "\\s*=\\s*([ˆ;]+)");
    return b ? b.pop() : "";
}

export function currencyFormat(amout: number) {
    return '$' + (amout/100).toFixed(2);
}