(function () {
    const wrapper = document.querySelector('[data-account-wrapper]');
    const loginToggle = document.querySelector('[data-open-login]');
    const registerToggle = document.querySelector('[data-open-register]');
    const activePanelField = document.querySelector('[data-active-panel]');

    if (!wrapper) {
        return;
    }

    const activatePanel = (panel) => {
        if (panel === 'register') {
            wrapper.classList.add('show-register');
        } else {
            wrapper.classList.remove('show-register');
        }

        if (activePanelField) {
            activePanelField.value = panel;
        }
    };

    loginToggle?.addEventListener('click', (event) => {
        event.preventDefault();
        activatePanel('login');
    });

    registerToggle?.addEventListener('click', (event) => {
        event.preventDefault();
        activatePanel('register');
    });

    const currentPanel = activePanelField?.value || 'login';
    activatePanel(currentPanel);
})();
