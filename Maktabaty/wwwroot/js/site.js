

$(document).ready(function () {
    // disable submit button after form submission to prevent multiple submissions
    document.addEventListener("submit", function (e) {
        const form = e.target;

        if (form.tagName.toLowerCase() !== "form") return;

        // if jQuery validation exists
        if (window.jQuery && $(form).data('validator')) {
            if (!$(form).valid()) return; // ❌ don't disable if invalid
        }

        const btn = form.querySelector('button[type="submit"], input[type="submit"]');
        if (!btn) return;

        if (btn.dataset.submitted === "true") return;

        btn.dataset.submitted = "true";
        btn.disabled = true;

        btn.dataset.originalText = btn.innerHTML;

        btn.innerHTML = `
        <span class="spinner-border spinner-border-sm me-1"></span>
        Please wait...
    `;
    });

});