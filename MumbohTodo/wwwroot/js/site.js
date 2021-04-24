// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

if ('caches' in window) {
    const cacheName = 'offlineSave-V1';
    let offlineBtn = $("#OfflineSave");

    let checkCache = (url, changeCache = true) => {
        caches.open(cacheName).then((cache) => {
            cache.match(url).then((response) => {
                let match = ('object' == typeof response);
                if (match) {
                    if (changeCache)
                        cache.delete(window.location.href);

                    if (changeCache) {
                        offlineBtn.val('Save Offline');

                    } else {
                        offlineBtn.val('Remove');
                    }
                } else {
                    if (changeCache)
                        cache.add(window.location.href)

                    if (changeCache) {
                        offlineBtn.val('Remove')
                    } else {
                        offlineBtn.val('Save for offline');
                    }
                }
            });
        });

    }
        offlineBtn.on("click", () => {
            checkCache(window.location.href);

        });
        checkCache(window.location.href, false);
        offlineBtn.removeAttr('hiden');

    }