/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml'],
    theme: {
        extend: {
            container: {
                center: true,
            }
        },
    },
    plugins: [require('daisyui')],
}

