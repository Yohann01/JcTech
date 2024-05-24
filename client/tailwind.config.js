/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,js}"],
  theme: {
    extend: {
      backgroundImage: {
        'customGradient': 'linear-gradient(32deg, rgba(16,32,98,1) 0%, rgba(58,102,231,1) 50%, rgba(162,227,255,1) 100%)',
      },
      colors: {
        customHover: '#68D2DF',
      },
    },
  },
  plugins: [],
}